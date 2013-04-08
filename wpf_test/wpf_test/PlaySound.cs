using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Windows.Media;

namespace common
{
    public class Sound
    {
        #region private member

        private MediaPlayer SP = new MediaPlayer();

        #endregion

        #region properties

        private Queue<string> mediaFileQueue = new Queue<string>();

        public Queue<string> MediaFileQueue
        {
            get { return mediaFileQueue; }
            set { mediaFileQueue = value; }
        }


        #endregion
        #region constr

        public Sound(string[] filenames)
        {
            SP.MediaFailed += SP_MediaFailed;
            SP.MediaOpened += SP_MediaOpened;
            SP.MediaEnded += SP_MediaEnded;

            foreach (var f in filenames)
            {
                MediaFileQueue.Enqueue(f);
            }
        }

        #endregion

        #region event handler

        void SP_MediaOpened(object sender, EventArgs e)
        {
            // add opened logic here
        }

        void SP_MediaFailed(object sender, ExceptionEventArgs e)
        {
            throw new Exception("file open failed");
        }

        void SP_MediaEnded(object sender, EventArgs e)
        {
            PlaySequence();
        }
        #endregion
        
        public void PlaySequence()
        {
            string fileName = MediaFileQueue.Dequeue();

            PlaySound(fileName);
        }

        public void PlaySound(string fileName)
        {
            try
            {
                    SP.Open(new System.Uri(fileName, UriKind.Relative));
                    SP.Play();
            }
            catch (FileNotFoundException)
            {
            }

            catch (FormatException)
            {
            }
        }

    }
}

   



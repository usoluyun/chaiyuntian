using System;
using System.Collections.Generic;
using System.IO;
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

        //播放队列属性 
        //什么是属性：http://msdn.microsoft.com/en-us/library/x9fsa0sw.aspx
        public Queue<string> MediaFileQueue
        {
            get { return mediaFileQueue; }
            set { mediaFileQueue = value; }
        }


        #endregion
        #region constr

        public Sound(string[] filenames)
        {
            //构造函数中初始化播放器的事件响应
            //播放器事件文档：http://msdn.microsoft.com/en-us/library/system.windows.media.mediaplayer.aspx
            SP.MediaFailed += SP_MediaFailed;
            SP.MediaOpened += SP_MediaOpened;
            SP.MediaEnded += SP_MediaEnded;

            //播放列表进队列
            foreach (var f in filenames)
            {
                MediaFileQueue.Enqueue(f);
            }
        }

        #endregion

        #region event handler

        /// <summary>
        /// 打开播放文件时触发此事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SP_MediaOpened(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 打开文件失败时触发此事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SP_MediaFailed(object sender, ExceptionEventArgs e)
        {
            throw new Exception("file open failed");
        }

        void SP_MediaEnded(object sender, EventArgs e)
        {
            PlaySequence();
        }
        #endregion

        /// <summary>
        /// 播放完成触发此事件
        /// </summary>
        public void PlaySequence()
        {
            //从队列里拿下一个文件
            string fileName = MediaFileQueue.Dequeue();

            PlaySound(fileName);
        }

        /// <summary>
        /// 播放
        /// </summary>
        /// <param name="fileName"></param>
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





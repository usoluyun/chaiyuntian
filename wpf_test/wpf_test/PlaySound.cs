using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Windows.Media;
  
namespace common
{       

     
    class Sound
    {
             
         public void PlaySound(string s,string format)
        {

            MediaPlayer SP = new MediaPlayer();
                
         
             
             try
            {
                //System.IO.Directory.GetCurrentDirectory() + "\\" +
                 SP.Open(new System.Uri( s + "." + format,UriKind.Relative));
                 SP.Play();

            }

            catch (System.IO.FileNotFoundException ex)
            {
            }

            catch(FormatException ex)
            {
            }
            
        }

       

        public void PlaySequence(string[] s,string format,int interval)
        {


            for (int i = 0; i < s.Length; i++)
            {
                PlaySound(s[i],format);

            }
        }

        }


    }

   



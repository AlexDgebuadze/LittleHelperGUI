using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LittleHelperGUI.FileManip
{
    public abstract class FileMan
    {
        public static void ReadAndEdit(string FileName, string old_value, string new_value)
        {
            try
            {
                FileStream ifs = new FileStream(@FileName, FileMode.Open, FileAccess.ReadWrite);
                StreamReader sr = new StreamReader(ifs);
                string data;
                data = sr.ReadToEnd();
                data = data.Replace(old_value, new_value);
                ifs.SetLength(0);
                byte[] s = Encoding.Default.GetBytes(data);
                ifs.Write(s, 0, s.Length);
                ifs.Close();
            }
            catch (Exception ex)
            {
               System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public static void CreateFolder(string @path, string FolderName)
        {

            try
            {
                System.IO.Directory.CreateDirectory(Path.Combine(path, FolderName));
            }
            catch (System.IO.IOException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

        }
        public static void CreateFile(string @path, string FileName , string PutIn = "")
        {

            try
            {
                using (StreamWriter wr = System.IO.File.CreateText(Path.Combine(path, FileName)))
                {
                    wr.WriteLine(PutIn);
                }


            }
            catch (System.IO.IOException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

        }


    }
}

using System.IO;

namespace MessageBoxForDevs.Misc
{
    public class LameFileOpener
    {
        public FileStream GimmeThatFile()
        {
            return File.Open("wellthisprobablydoesntexistatall.txt", FileMode.Open);
        }
    }
}

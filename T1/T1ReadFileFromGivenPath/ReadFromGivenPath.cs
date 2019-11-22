using System;
using System.IO;

namespace T1ReadFileFromGivenPath
{
    public class ReadFromGivenPath
    {
        public void RunFromGivenPathAndFile(string fullPath)
        {
            try
            {
                var readFile = File.ReadAllText(fullPath);
                Console.WriteLine(readFile);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DriveNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FieldAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (PathTooLongException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine(fullPath);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileDemo1
{
    class Program
    {

        static void Main(string[] args)
        {
           // String roothPath = @"D:\Prakash";
           //string[] filePaths;

            List<string> tempBatchAddresses;
            tempBatchAddresses = Directory.GetFiles(@"D:\Prakash", "*.txt").ToList();
            tempBatchAddresses.AddRange(Directory.GetFiles(@"D:\Prakash\Prakash", "*.txt").ToList());
            tempBatchAddresses.AddRange(Directory.GetFiles(@"D:\Prakash\New folder", "*.txt").ToList());
            // filePaths = tempBatchAddresses.ToArray();
            // string[] k = tempBatchAddresses.ToArray();// ToString();
            foreach (string fo in tempBatchAddresses)
            {
                string[] file = new string[] { fo };
            
               //  filePaths = Directory.GetFiles(fo);
               ReadFiles(file);
                
            }
           

                        // foreach (char path in roothPath)
                        // {
                    //  filePaths = Directory.GetFiles(roothPath);
               //ReadFiles(filePaths);
            //Console.WriteLine("Prakash"+filePaths.ToString());
              //  Console.WriteLine("Kristen Stewart");
          //  }
            

            // string begin1 = "begin";
            // string end1 = "end";
            // int count = 0;
            //// int count1 = 0;

            // string[] file = { "Prakash" ,"Emma Watson"};

            // foreach(string fr in file)
            // {
            //     if(fr==begin1)
            //     {
            //         count=count+1;
            //     }
            //     else if(fr==end1)
            //     {
            //         count=count-1;
            //     }
            // }
            // if(count==0)
            // {

            // }



        }

        private static void ReadFiles(string[] filePaths)
        {
            //throw new NotImplementedException();
            string file2;
            foreach (string file1 in filePaths)
            {
               // string file1 = file.ToString();
                Console.WriteLine(file1);
                
                if (file1.Contains(".txt"))
                {
                    file2 = file1.Replace(".txt", "_op.sql");
                   // file2 = file2.Replace("", @"Prakash");
                    EditFile(file1, file2);

                }

            }
        }

        private static void EditFile(string line, string line2)
        {

            using (var writer = new StreamWriter(line2))
            {
                // throw new NotImplementedException();
                var keyword = "begin";
                var keyword1 = "end;";// Console.ReadLine() ?? "";
                var slash = "/";
                // var commit = "commit;";

                int count = 0;
                using (var sr = new StreamReader(line))
                {
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        // if (String.IsNullOrEmpty(line)) ;
                        if (line.IndexOf(keyword, StringComparison.CurrentCultureIgnoreCase) >= 0)
                        {
                            count++;
                            //Console.WriteLine(count);
                        }
                        else
                        {
                            //line = sr.ReadLine();
                            // if (String.IsNullOrEmpty(line)) continue;
                            if (line.IndexOf(keyword1, StringComparison.CurrentCultureIgnoreCase) >= 0)
                            {
                                count--;
                                //  Console.WriteLine(count);
                            }
                        }
                        if (count == 0 )
                        {
                            if (line.Contains("/"))
                            {

                                line = line.Replace(slash, " go");
                                // Console.WriteLine("Emma Roberts");
                                // Console.WriteLine(line);
                            }
                            if (line.IndexOf("commit;", StringComparison.CurrentCultureIgnoreCase) >= 0)
                            {
                                line = line.Replace("commit;", " commit go");
                                //  Console.WriteLine("Keanu Reeves");
                                //Console.WriteLine(line);
                            }
                            if (line != "end;")
                            {
                                if (line.IndexOf(";", StringComparison.CurrentCultureIgnoreCase) >= 0)
                                {
                                    line = line.Replace(";", " go");
                                    //  Console.WriteLine("Margret qualley");
                                    //Console.WriteLine(line);
                                }
                            }

                        }






                        writer.WriteLine(line);
                        /// writer.Close();
                    }
                }

            }

        }

    }
}



using System;
using System.Collections.Generic;

namespace ProgramForReadNr
{
    public class ReadNr
    {

        public ReadNr()
        {
            ListNr = new List<int>(20000);
            this.Min = 1;
            this.Max = 100;
            ListNr.Add(Min);

        }

        private readonly int Min;
        private readonly int Max;
        private List<int> ListNr;

        public void ReadNumber(int start, int end)
        {

            if (start < Min && end > Max)
            {
                throw new IndexOutOfRangeException($"The start is lower than {Min} and end higher than {Max}");
            }
            else
            {
                if ((start == Min && end == Max))
                {
                    throw new DuplicateNumberException($"{start} is equal {Min} or {end} is equal {Max}");

                }
                //                else
                //                {
                //                    ListNr.Add(start);
                //                    ListNr.Add(end);
                //                }
            }

            Console.WriteLine($"Enter enters 10 numbers between {start} and {end} but lower than {Max} and higher than {Min}");
            var nr = 0;
            var count = 0;
            string reader = null;
            while (count < 10)
            {
                try
                {
                    reader = Console.ReadLine();
                    nr = Int32.Parse(reader);
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Invalid number {reader} is not a number {e.Message}");
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
                //                finally
                //                {
                //
                //                }


                try
                {
                    if (nr > start && nr < end)
                    {
                        if (!ListNr.Contains(nr))
                        {
                            ListNr.Add(nr);
                        }
                        else
                        {
                            throw new DuplicateNumberException(
                                $"The nr is inserted {nr} is equal with the nr at index {ListNr.IndexOf(nr)}");
                            break;
                        }
                    }
                    else
                    {
                        throw new IndexOutOfRangeException($"The nr is higher than {end} and lower than {start}");
                        break;
                    }
                }
                catch (DuplicateNumberException e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
                count++;
                if (count == 9)
                {
                    ListNr.Add(100);
                }

            }
            ListNr.Sort();
            PrintList(ListNr);

        }

        private void PrintList(List<int> list)
        {
            foreach (var i in list)
            {
                Console.Write(i);
                Console.Write("<");
            }
        }


    }
}
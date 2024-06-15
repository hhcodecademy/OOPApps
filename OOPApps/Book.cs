using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApps
{
    internal class Book
    {

        public Book(string text)
        {
            this.Text = text;
            string[] array = this.Text.Split(' ');
            this._wordcount = array.Length;
        }


        private int _wordcount { get; set; }
        public string Title { get; set; }

        public string Text { get; set; }

        public int PageCount { get; set; }
        public int WordCount
        {

            get
            {
                return _wordcount;
            }

        }


        public int CalculateMemory()
        {
            int totalSize = this._wordcount * 2;
            return totalSize;

        }


    }
}

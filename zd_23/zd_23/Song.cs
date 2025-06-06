using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_23
{
    struct Song
    {
        public string Author;
        public string Title;
        public string Filename;

        // контруктор
        public Song(string aut, string title, string fname)
        {
            Author = aut;
            Title = title;
            Filename = fname;
        }

        // урезанный конструктор
        public Song(string aut, string fname)
        {
            Author = aut;
            Title = "Неизвестен";
            Filename = fname;
        }

        // сравнение двух объектов
        static public bool Equality(Song s1, Song s2)
        {
            if (s1.Author == s2.Author && s1.Title == s2.Title && s1.Filename == s2.Filename ) return true;

            return false;
        }

        // сравнение объекта с полями структуры
        static public bool Equality(Song s1, string aut, string title, string fname)
        {
            if (s1.Author == aut && s1.Title == title && s1.Filename == fname) return true;

            return false;
        }

        // сравнение объекта с текстом
        static public bool Equality(Song s1, string text)
        {
            if (s1.Author == text || s1.Title == text || s1.Filename == text) return true;

            return false;
        }

        // информация в массиве
        public string[] Info()
        {
            return new string[] { this.Author, this.Title };
        }
        

    }
}

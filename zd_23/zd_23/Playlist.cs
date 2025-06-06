using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_23
{
    class Playlist
    {
        private List<Song> list_song;
        private int currentIndex;
        public bool play;

        // конструктор класса плейлист
        public Playlist()
        {
            list_song = new List<Song>();
            currentIndex = 0;
        }

        // конструктор класса плейлист
        public int CurrentIndex()
        {
            return currentIndex;
        }

        // Получение текущей аудиозаписи
        public Song CurrentSong()
        {
            if (list_song.Count > 0)
                return list_song[currentIndex];
            else
                throw new IndexOutOfRangeException("Невозможно получить текущую аудиозапись для пустого плейлиста");
        }

        // Получение текущей аудиозаписи
        public bool CurrentSongInfo(out string name, out string aut)
        {
            if (list_song.Count > 0)
            {
                string[] oper = list_song[currentIndex].Info();

                name = oper[0];
                aut = oper[1];

                return true;
            }
            else
            {
                name = "";
                aut = "";

                return false;
            }
        }

        // добавление аудиозаписи по структуре Song
        public bool AddSong(Song new_song)
        {
            foreach (Song s in list_song)
            {
                if (Song.Equality(s, new_song)) return false;
            }

            list_song.Add(new_song);
            return true;
        }

        // добавление аудиозаписи и создание структуры Song по данным
        public bool AddSong(string aut, string titl, string f_name)
        {
            foreach (Song s in list_song)
            {
                if (Song.Equality(s, aut, titl, f_name)) return false;
            }

            list_song.Add(new Song(aut, titl, f_name));
            return true;
        }

        // переход к следующей
        public bool GoToNextSong(out string message)
        {
            if (list_song.Count == 0)
            {
                message = "Плейлист пустой";
                return false;
            }

            if (currentIndex + 1 >= list_song.Count)
            {
                message = "Конец плейлиста";
                return false;
            }

            currentIndex++;

            message = "";
            return true;
        }

        // переход в конец
        public bool GoToBackSong(out string message)
        {
            if (list_song.Count == 0)
            {
                message = "Плейлист пустой";
                return false;
            }

            if (currentIndex == 0)
            {
                message = "Начало плейлиста";
                return false;
            }

            message = "";
            currentIndex--;
            return true;
        }

        // переход по индексу
        public bool GoToIndexSong(int index, out string message)
        {
            if (list_song.Count == 0)
            {
                message = "Плейлист пустой";
                return false;
            }

            if (0 <= index && index < list_song.Count)
            {
                currentIndex = index;
                message = "";
                return true;
            }

            message = "Индекс отсутсвует в плейлисте";
            return false;
        }

        // переход в начало
        public bool GoToBegSong(out string message)
        {
            if (list_song.Count == 0)
            {
                message = "Плейлист пустой";
                return false;
            }

            message = "";
            currentIndex = 0;
            return true;
        }

        // переход по тексту
        public bool GoToTextSong(string text, out string message)
        {
            message = "";

            if (list_song.Count == 0)
            {
                message = "Плейлист пустой";
                return false;
            }

            for (int i = 0; i < list_song.Count; i++)
            {
                if (Song.Equality(list_song[i], text))
                {
                    currentIndex = i;
                    return true;
                }
            }

            message = "Такой записи не найдено";
            return false;
        }

        // удаление по индексу
        public bool RemovSong(int index, out string message)
        {
            if (list_song.Count == 0)
            {
                message = "Плейлист пустой";
                return false;
            }

            if (0 <= index && index < list_song.Count)
            {
                list_song.RemoveAt(index);
                if (index == currentIndex) currentIndex = 0;

                message = "";
                return true;
            }

            message = "Индекс отсутсвует в плейлисте";
            return false;
        }

        // удаление по объекту
        public bool RemovSong(Song song, out string message)
        {
            if (list_song.Count == 0)
            {
                message = "Плейлист пустой";
                return false;
            }

            for (int i = 0; i < list_song.Count; i++)
            {
                if (Song.Equality(song, list_song[i]))
                {
                    return RemovSong(i, out message);
                }
            }

            message = "Аудиозаписи нет в плейлисте";
            return false;
        }

        // удаление плейлиста
        public void RemovPlaylist()
        {
            currentIndex = 0;
            list_song.Clear();
        }

        
    }
}

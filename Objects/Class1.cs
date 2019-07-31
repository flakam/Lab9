using System;
using System.Collections.Generic;
using System.Text;

namespace Objects
{
    class Student
    {
        public string Name;
        public string HomeTown;
        public string FavoriteFood;
        public string FavoriteColor;

        public Student(string name, string homeTown, string favoriteFood,string favoriteColor)
        {
            Name = name;
            HomeTown = homeTown;
            FavoriteFood = favoriteFood;
            FavoriteColor = favoriteColor;
        }

        public Student()
        {
        }
        //public string Newstudent()
        //{
           // return Newstudent;

        //}
        public string GetName()
        {
            return Name;
        }

        public string GetHomeTown()
        {
            return HomeTown;
        }

        public string GetFavoriteFood()
        {
            return FavoriteFood;
        }
        public string GetFavoriteColor()
        {
            return FavoriteColor;
        }
        public void SetFavoriteColor(string _color)
        {
            FavoriteColor = _color;
        }
        public void SetFavoriteFood(string _favoriteFood)
        {
            FavoriteFood= _favoriteFood;
        }
        public void SetHomeTown(string _hometown)
        {
            HomeTown = _hometown;
        }
        public void SetName(string _name)
        {
            Name = _name;
        }
    }
}
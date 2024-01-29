using System;
using System.Collections.Generic;
using WanderLog.Models;

namespace WanderLog.Models
{
    public class Place
    {
        public string CityName { get; set; }

        // 4 things to be implemented: cityname, pictures, how long you stayed, with whom you travelled with and ta journeal entry... I will mplement all of this.
        public object Picture { get; set; }
        public string TimeOfStay { get; set; }
        public string TravelBuddy { get; set; }
        public string JournalEntry { get; set; }

        private static List<Place> _myListOfPlaces = new List<Place>(){};

        public int Id { get; }
        
        
        
        public Place(string myCityName, object myPicture, string myTimeOfStay, string myTravelBuddy, string myJournalEntry)
        {
            CityName = myCityName;
            Picture = myPicture;
            TimeOfStay = myTimeOfStay;
            TravelBuddy = myTravelBuddy;
            JournalEntry = myJournalEntry;

            // Adding each object(place) to the list of places
            _myListOfPlaces.Add(this);

            // setting the value of a readonly field inside the constructor
            Id = _myListOfPlaces.Count;
        }

        // Implementing the GetAllPlaces method to store all place objects in a list

        public static List<Place> GetAllPlaces()
        {
            return _myListOfPlaces;
        }

        public static void ClearAllPlaces()
        {
            // The inbuilt Clear() method for collections(Dictionaries, list: Remember Arrays cannot be altered/cleared once they are created)
            _myListOfPlaces.Clear();
        }

        // Implementing the FindPlace() method
        public static Place FindPlace(int placeId)
        {
           
            return _myListOfPlaces[placeId - 1];
            // returns a Place object by passing in the object's id
            
            // Since .Count will count 1,2,3 but my array uses index by doing: 0,1,2,3
        }

    }
}
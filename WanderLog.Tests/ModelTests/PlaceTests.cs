using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WanderLog.Models;

namespace WanderLog.Tests
{
    [TestClass]
    // NOTE: Anytime you inherit the IDisposable interface
    public class WanderLogTests : IDisposable
    {
        public void Dispose()
        {
            Place.ClearAllPlaces();
        }
        // 1st Test: Creates Instance of Place class .C# Creates me a free empty constructor because I have a class but no constructor yet
        [TestMethod]
        public void PlaceConstructor_CreatesInstanceOfPlaceClass_Place()
        {
            // Arrange
            Place newPlace = new Place("Jand", "Us Picture", "3 weeks", "Wiffie", "More about my Trip; we went to Vegas");

            // Assert
            Assert.AreEqual(typeof(Place), newPlace.GetType());
        }

        // 2nd Test: Test to get the string cityName from of a Place class
        [TestMethod]
        public void GetCityName_ReturnsCityNameOfPlaceClass_String()
        {
            // Arrange
            Place newPlace = new Place("Abuja", "Dog Picture", "Thirty days", "Wiffie", "More about my Trip; we went to Vegas");
            string expectedCityName = "Abuja";

            // Act
            string returnedCityName = newPlace.CityName;

            // Assert
            Assert.AreEqual(expectedCityName, returnedCityName);
        }

        // 3rd Test: Test to set the CityName property of object Place
        [TestMethod]
        public void SetCityName_SetsCityNameOfPlaceClass_Void()
        {
            // Arrange
            Place newPlace = new Place("Abuja", "Dog Picture", "Thirty days", "Wiffie", "More about my Trip; we went to Vegas");
            string setCityName = "New York";

            // Act
            newPlace.CityName = setCityName;

            // Assert
            Assert.AreEqual(setCityName, newPlace.CityName);
        }

        // 4th Test: Test to get the object picture from of a Place class
        [TestMethod]
        public void GetPicture_ReturnsPictureOfPlaceClass_String()
        {
            // Arrange
            Place newPlace = new Place("Abuja", "Dog Picture", "Thirty days", "Wiffie", "More about my Trip; we went to Vegas");
            object expectedPicture = "Dog Picture";

            // Act
            object returnedPicture = newPlace.Picture;

            // Assert
            Assert.AreEqual(expectedPicture, returnedPicture);
        }

        // 5th Test: Test to set the object picture from of a Place class
        [TestMethod]
        public void SetPicture_ReturnsPictureOfPlaceClass_String()
        {
            // Arrange
            Place newPlace = new Place("Abuja", "Dog Picture", "Thirty days", "My Girlfriend", "More about my Trip; we went to Vegas");
            object expectedPicture = "Bunty Hunter";

            // Act
            newPlace.Picture = expectedPicture;

            // Assert
            Assert.AreEqual(expectedPicture, newPlace.Picture);
        }

        // 6th Test: Test to get the string TimeOfStay from of a Place class
        [TestMethod]
        public void GetTimeOfStay_ReturnsTimeOfStayOfPlaceClass_String()
        {
            // Arrange
            Place newPlace = new Place("Abuja", "Dog Picture", "Six months", "My Mom", "More about my Trip; we went to Vegas");
            string expectedTimeOfStay = "Six months";

            // Act
            string returnedTimeOfStay = newPlace.TimeOfStay;

            // Assert
            Assert.AreEqual(expectedTimeOfStay, returnedTimeOfStay);
        }

        // 7th Test: Test to set the TimeOfStay property of object Place
        [TestMethod]
        public void SetTimeOfStay_SetsTimeOfStayOfPlaceClass_Void()
        {
            // Arrange
            Place newPlace = new Place("Abuja", "Dog Picture", "Thirty days", "My Mom", "More about my Trip; we went to Vegas");
            string setTimeOfStay = "New York";

            // Act
            newPlace.TimeOfStay = setTimeOfStay;

            // Assert
            Assert.AreEqual(setTimeOfStay, newPlace.TimeOfStay);
        }

        // 8th Test: Test to get the string TravelBuddy from of a Place class
        [TestMethod]
        public void GetTravelBuddy_ReturnsTravelBuddyOfPlaceClass_String()
        {
            // Arrange
            Place newPlace = new Place("Abuja", "Dog Picture", "Six months", "My Girlfriend", "More about my Trip; we went to Vegas");
            string expectedTravelBuddy = "My Girlfriend";

            // Act
            string returnedTravelBuddy = newPlace.TravelBuddy;

            // Assert
            Assert.AreEqual(expectedTravelBuddy, returnedTravelBuddy);
        }

         // 9th Test: Test to set the TravelBuddy property of object Place
        [TestMethod]
        public void SetTravelBuddy_SetsTravelBuddyOfPlaceClass_Void()
        {
            // Arrange
            Place newPlace = new Place("Abuja", "Dog Picture", "Thirty days", "My Mom", "More about my Trip; we went to Vegas");
            string setTravelBuddy = "My Elder Sister";

            // Act
            newPlace.TravelBuddy = setTravelBuddy;

            // Assert
            Assert.AreEqual(setTravelBuddy, newPlace.TravelBuddy);
        }

         // 10th Test: Test to get the string JournalEntry from of a Place class
        [TestMethod]
        public void GetJournalEntry_ReturnsJournalEntryOfPlaceClass_String()
        {
            // Arrange
            Place newPlace = new Place("Abuja", "Dog Picture", "Six months", "My Girlfriend", "More about my Trip; we went to the Bahamas and to the Himalayas");
            string expectedJournalEntry = "More about my Trip; we went to the Bahamas and to the Himalayas";

            // Act
            string returnedJournalEntry = newPlace.JournalEntry;

            // Assert
            Assert.AreEqual(expectedJournalEntry, returnedJournalEntry);
        }

         // 11th Test: Test to set the JournalEntry property of object Place
        [TestMethod]
        public void SetJournalEntry_SetsJournalEntryOfPlaceClass_Void()
        {
            // Arrange
            Place newPlace = new Place("Abuja", "Dog Picture", "Thirty days", "My Mom", "More about my Trip; we went to Vegas");
            string setJournalEntry = "Went to Nigeria";

            // Act
            newPlace.JournalEntry = setJournalEntry;

            // Assert
            Assert.AreEqual(setJournalEntry, newPlace.JournalEntry);
        }
        

        // 12th Test: Test to get all place object in my list of laces
        [TestMethod]
        public void GetAllPlaces_ReturnsAllPlaceClass_Void()
        {
            // Arrange
            Place newPlace1 = new Place("Abuja", "Dog Picture", "Thirty days", "My Mom", "More about my Trip; we went to Vegas");
            Place newPlace2 = new Place("Vegas", "Dog Picture", "Thirty days", "My Mom", "More about my Trip; we went to Vegas");
            Place newPlace3 = new Place("Los Angeles", "Dog Picture", "Thirty days", "My Mom", "More about my Trip; we went to Vegas");
            
            List<Place> expectedListOfPlaces = new List<Place>() { newPlace1, newPlace2, newPlace3 };

            // Act
            List<Place> returnedListOfPlaces = Place.GetAllPlaces();

            // Assert
            CollectionAssert.AreEqual(expectedListOfPlaces, returnedListOfPlaces);
        }

        // I need a ClearAllPlaces method to make my last test pass.
        // To ensure I clear my list of places everytime I would need to implement aninterface called IDisposabe
        // IDisposable implements a method called Dispose() which will run the code I put in it after every test.. This ensures previous tests wuld not affect the current test, hence my GetAllPlaces() method works

        // 13th Test: Test for ClearAll()
        [TestMethod]
        public void ClearAllPlaces_ReturnsAllPlaceClass_Void()
        {
            // Arrange
            Place newPlace1 = new Place("Abuja", "Dog Picture", "Thirty days", "My Mom", "More about my Trip; we went to Vegas");
            Place newPlace2 = new Place("Vegas", "Dog Picture", "Thirty days", "My Mom", "More about my Trip; we went to Vegas");
            Place newPlace3 = new Place("Los Angeles", "Dog Picture", "Thirty days", "My Mom", "More about my Trip; we went to Vegas");
            
            // empty list
            List<Place> expectedListOfPlaces = new List<Place>() {};

            // Act
            Place.ClearAllPlaces();
            // After clearing, I am confirming my ClearAllPlaces() method works by getting me list again after I ran the ClearAllPlaces() method
            List<Place> emptyListOfPlaces = Place.GetAllPlaces();

            // Assert
            CollectionAssert.AreEqual(expectedListOfPlaces, emptyListOfPlaces);
        }

        // 14th Test: Test for FindPlace()
         public void FindPlace_ReturnsASpecific_Void()
        {
            // Arrange
            Place newPlace1 = new Place("Abuja", "Dog Picture", "Thirty days", "My Mom", "More about my Trip; we went to Vegas");
            Place newPlace2 = new Place("Vegas", "Dog Picture", "Thirty days", "My Mom", "More about my Trip; we went to Vegas");
            Place newPlace3 = new Place("Los Angeles", "Dog Picture", "Thirty days", "My Mom", "More about my Trip; we went to Vegas");
            
            // Act
            Place FoundThePlace = Place.FindPlace(1);
           
            // Assert
            Assert.AreEqual(newPlace1, FoundThePlace);
        }



        
    }
}
using System;
using System.ComponentModel;
using CarouselViewChallenge.ViewModels;

namespace CarouselViewChallenge.Models
{
    public class FoodItem:BaseViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; } = "Paneer Tikka (8 Pcs)";
        public string Description { get; set; } = "Fine & Dine SPECIAL";
        public bool IsVeg { get; set; } = true;
        public string BasePrice { get; set; }
        public bool HasPromo { get; set; } = true;
        public string PromoPrice { get; set; }
        public string Image { get; set; } = "food.png";
        string totalPrice { get; set; }
        public string TotalPrice { get { return totalPrice; } set { totalPrice = value; OnPropertyChanged(new PropertyChangedEventArgs("TotalPrice")); } }
        int quantity { get; set; }
        public int Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
                TotalPrice = (quantity * int.Parse(BasePrice)).ToString();
                OnPropertyChanged(new PropertyChangedEventArgs("Quantity"));
            }
        }

    }
    public class CategoryModel
    {
        public string Icon { get; set; }
        public int Id { get; set; }
    }
}

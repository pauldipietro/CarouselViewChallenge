using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using CarouselViewChallenge.Models;

namespace CarouselViewChallenge.ViewModels
{
    public class CarouselViewModel:BaseViewModel
    {
        ObservableCollection<FoodItem> _foodBanners { get; set; }
        public ObservableCollection<FoodItem> FoodBanners { get { return _foodBanners; } set { _foodBanners = value; OnPropertyChanged(new PropertyChangedEventArgs("FoodBanners")); } }
        ObservableCollection<CategoryModel> _foodCategory { get; set; }
        public ObservableCollection<CategoryModel> FoodCategory
        {
            get { return _foodCategory; }
            set { _foodCategory = value; OnPropertyChanged(new PropertyChangedEventArgs("FoodCategory")); }
        }
        public CarouselViewModel()
        {
            GetBanners();
            GetCategory();
        }
        void GetBanners()
        {
            var data = new ObservableCollection<FoodItem> {
                new FoodItem{Id="0",Image="https://as1.ftcdn.net/jpg/02/17/34/30/500_F_217343007_9Gpk6FQLW4VKtQ971OwAeMxds6v7lTZk.jpg",Name="Cheeseburger",Description="Double cheeseburger with lettuce, tomato, onion, and melted american cheese with panoramic composition",PromoPrice="$3.15"},
                new FoodItem{Id="1",Image="https://as2.ftcdn.net/jpg/02/08/19/97/500_F_208199732_GTIyDu8pqRdqvvyKUjtcKDfVvJfHeLxl.jpg",Name="Hands taking pizza",Description="Pepperoni, sausage, mushrooms, green pepper, onions, black olives, and then top it all with shredded mozzarella cheese",PromoPrice="$4"},
                new FoodItem{Id="2",Image="https://as1.ftcdn.net/jpg/02/65/59/18/500_F_265591805_CFSoiDqPmbKJF1dtXvHcYYLTaIzrUfxW.jpg",Name="Pasta with grilled vegetables",Description=" Zucchini, eggplant, bell pepper ant tomato in white bowl",PromoPrice="$0.89"},
                new FoodItem{Id="3",Image="https://as1.ftcdn.net/jpg/01/09/75/90/500_F_109759077_SVp62TBuHkSn3UsGW4dBOm9R0ALVetYw.jpg",Name="Spaghetti",Description="Green salad, corn, cheese bread, almond green beans, roasted vegetables, d spinach salad, mushroom peas, brussel sprouts.",PromoPrice="$5.5"}
            };
            FoodBanners = data;
        }
        public void GetCategory()
        {
            var list = new List<CategoryModel> {
                new CategoryModel{Icon="https://as2.ftcdn.net/jpg/02/18/23/11/500_F_218231188_Vp14PsaUJUwjw8jP1NGPaYiayjUPgtP1.jpg" ,Id=0},
                new CategoryModel{Icon="https://as1.ftcdn.net/jpg/02/58/43/30/500_F_258433064_mJhaTmeRh8Qmehpg3C4jBWj6gJ9A8Kwk.jpg" ,Id=1},
                new CategoryModel{Icon="https://as1.ftcdn.net/jpg/01/23/23/54/500_F_123235458_cJRxxWxG9qiEEzr7DdMYYe2H093wmQ2E.jpg" ,Id=2},
                new CategoryModel{Icon="https://as2.ftcdn.net/jpg/00/49/40/59/500_F_49405968_wSQGvOhtvT6J1yXK5dgg6qT7VcEi5Xss.jpg" ,Id=3},
                 new CategoryModel{Icon="https://as2.ftcdn.net/jpg/01/13/18/69/500_F_113186932_yKboHIqNvKISmx8FefqPnKjNlMlW0srp.jpg" ,Id=4},
                new CategoryModel{Icon="https://as1.ftcdn.net/jpg/01/37/12/18/500_F_137121899_w4jpKuzB233Lrg6zfPkQVfY10gCBXfdK.jpg" ,Id=5},
                new CategoryModel{Icon="https://as2.ftcdn.net/jpg/02/18/23/11/500_F_218231188_Vp14PsaUJUwjw8jP1NGPaYiayjUPgtP1.jpg" ,Id=0},
                new CategoryModel{Icon="https://as1.ftcdn.net/jpg/02/58/43/30/500_F_258433064_mJhaTmeRh8Qmehpg3C4jBWj6gJ9A8Kwk.jpg" ,Id=1},
                new CategoryModel{Icon="https://as1.ftcdn.net/jpg/01/23/23/54/500_F_123235458_cJRxxWxG9qiEEzr7DdMYYe2H093wmQ2E.jpg" ,Id=2},
                new CategoryModel{Icon="https://as2.ftcdn.net/jpg/00/49/40/59/500_F_49405968_wSQGvOhtvT6J1yXK5dgg6qT7VcEi5Xss.jpg" ,Id=3},
                 new CategoryModel{Icon="https://as2.ftcdn.net/jpg/01/13/18/69/500_F_113186932_yKboHIqNvKISmx8FefqPnKjNlMlW0srp.jpg" ,Id=4},
                new CategoryModel{Icon="https://as1.ftcdn.net/jpg/01/37/12/18/500_F_137121899_w4jpKuzB233Lrg6zfPkQVfY10gCBXfdK.jpg" ,Id=5}

            };
            FoodCategory = new ObservableCollection<CategoryModel>(list);
        }
    }
}

using DisneyPrincess.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DisneyPrincess.ViewModels
{
    public class MyListPageViewModel
    {
        public ObservableCollection<MyListModel> DisneyPrincess {  get; set; }
        public MyListPageViewModel()
        {
            DisneyPrincess = new ObservableCollection<MyListModel>();
            DisneyPrincess.Add(new MyListModel 
            { 
                Name="Merida", 
                Image= "https://imgix.bustle.com/rehost/2016/9/13/9cc6001f-4571-4425-ba33-2834762f4c34.jpg?w=800&fit=crop&crop=faces&auto=format%2Ccompress", 
                Detail= "Princess Merida is the protagonist of Disney•Pixar's 2012 animated feature film, Brave", 
                Personality= "Merida is a very bold, brave, daring, courageous, stubborn, rebellious, and headstrong girl who does not fit the stereotypical princess role. Rather than being a damsel in distress who is subservient to the customs, traditions, and social restrictions her society places on her and expects her to follow, Merida openly rebels and defies her heritage as a princess and would like for nothing more than to be a normal girl. She is very athletic and enjoys nothing more than riding her horse Angus and practicing her archery, of which she is the best in the kingdom. She also seems to be skilled in sword fighting, as shown in the Brave featurette \"Cutting the Class\". Merida tends to be ungraceful and has bad manners, and is extremely tomboyish." 
            });
            DisneyPrincess.Add(new MyListModel
            {
                Name = "Ariel",
                Image= "https://static.wikia.nocookie.net/disney/images/8/8a/Profile_-_Ariel.jpg/revision/latest?cb=20230913063128",
                Detail = "Ariel is a fictional character in Walt Disney Pictures’ 28th animated feature film, The Little Mermaid",
                Personality = "Ariel is a bright, spirited, and headstrong mermaid princess with a strong passion for adventure and exploration. Her tendency to explore the more mysterious depths of the ocean (or more importantly, the world beyond the ocean) can lead to an array of problems to both herself and her friends, and in the confines of her personal life - as seen when she gets into an argument with her overprotective father, King Triton. Despite this, Ariel's selflessness, compassion, and intuitive way of thinking often resolve such problems, as she always takes full responsibility for her actions.\r\n\r\n"
            });
            }
    }
}


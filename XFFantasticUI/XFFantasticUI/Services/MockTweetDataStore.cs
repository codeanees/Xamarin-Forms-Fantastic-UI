using System.Collections.Generic;
using System.Threading.Tasks;
using XFFantasticUI.Models.MockTweet;

namespace XFFantasticUI.Services
{
    public static class MockTweetDataStore
    {
        static readonly List<Topic> topics;

        static MockTweetDataStore()
        {
            topics = new List<Topic>()
            {
                new Topic
                {
                    MainCategoryName = "Entertainment",
                    SubCategories =
                        new List<SubCategory>()
                        {
                            new SubCategory { Name = "Fire Force" },
                            new SubCategory { Name = "Dragon Ball" },
                            new SubCategory { Name = "Animated Flims" },
                            new SubCategory { Name = "Naturo" },
                            new SubCategory { Name = "Avatar: The Last Airblender" },
                            new SubCategory { Name = "Disney" },
                            new SubCategory { Name = "Marvel Universe" },
                            new SubCategory { Name = "Fire Force" },
                            new SubCategory { Name = "Dragon Ball" },
                            new SubCategory { Name = "Animated Flims" },
                            new SubCategory { Name = "Naturo" },
                            new SubCategory { Name = "Avatar: The Last Airblender" },
                            new SubCategory { Name = "Disney" },
                            new SubCategory { Name = "Marvel Universe" },
                            new SubCategory { Name = "Fire Force" },
                            new SubCategory { Name = "Dragon Ball" },
                            new SubCategory { Name = "Animated Flims" },
                            new SubCategory { Name = "Naturo" },
                            new SubCategory { Name = "Avatar: The Last Airblender" },
                            new SubCategory { Name = "Disney" },
                            new SubCategory { Name = "Marvel Universe" },
                            new SubCategory { Name = "Fire Force" },
                            new SubCategory { Name = "Dragon Ball" },
                            new SubCategory { Name = "Animated Flims" },
                            new SubCategory { Name = "Naturo" },
                            new SubCategory { Name = "Avatar: The Last Airblender" },
                            new SubCategory { Name = "Disney" },
                            new SubCategory { Name = "Marvel Universe" },
                            new SubCategory { Name = "Dragon Ball" },
                            new SubCategory { Name = "Animated Flims" },
                            new SubCategory { Name = "Naturo" },
                            new SubCategory { Name = "Avatar: The Last Airblender" },
                            new SubCategory { Name = "Disney" },
                            new SubCategory { Name = "Marvel Universe" }
                        },
                    ViewAllEnabled= true
                },
                new Topic
                {
                    MainCategoryName = "Gaming",
                    SubCategories =
                        new List<SubCategory>()
                        {
                            new SubCategory { Name = "Gaming News" },
                            new SubCategory { Name = "Call of Duty" },
                            new SubCategory { Name = "Play Station 1" },
                            new SubCategory { Name = "Play Station 2" },
                            new SubCategory { Name = "Play Station 3" },
                            new SubCategory { Name = "Play Station 4" },
                            new SubCategory { Name = "Play Station 5" },
                            new SubCategory { Name = "Play Station 6" },
                            new SubCategory { Name = "Play Station 7" },
                            new SubCategory { Name = "Play Station 8" },
                            new SubCategory { Name = "Play Station 9" },
                            new SubCategory { Name = "Play Station 10" }
                        },
                    ViewAllEnabled= true
                },
                new Topic
                {
                    MainCategoryName = "Science",
                    SubCategories =
                        new List<SubCategory>()
                        {
                            new SubCategory { Name = "Astronauts" },
                            new SubCategory { Name = "Physics" },
                            new SubCategory { Name = "Science News" },
                        },
                    ViewAllEnabled= true
                }
            };
        }
    
        public static async Task<IEnumerable<Topic>> GetTopicsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(topics);
        }
    }
}
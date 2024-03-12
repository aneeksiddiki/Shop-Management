namespace Shop_Management.Models
{
    public class CatagoriesRepository
    {
        private static List<Catagory> _catagories = new List<Catagory>()
        {
            new Catagory {CatagoryId = 1, Name = "Beverages" ,Description = "Beverages"},
            new Catagory {CatagoryId = 2, Name = "Bekary" ,Description = "Bekary"},
            new Catagory {CatagoryId = 3, Name = "Meat" ,Description = "Meat"}
        };

        public static void AddCatagory(Catagory catagory)
        {
            var maxId = _catagories.Count;
            catagory.CatagoryId += maxId;
            _catagories.Add(catagory);
        }

        public static List<Catagory> GetCatagories() => _catagories;

        public static Catagory? GetCatagoryById(int catagoryId)
        {
            var catagory = _catagories.FirstOrDefault(x => x.CatagoryId == catagoryId);

            if(catagory != null)
            {
                return new Catagory
                {
                    CatagoryId = catagory.CatagoryId,
                    Name = catagory.Name,
                    Description = catagory.Description,
                };
            }

            return null;
        }

        public static void UpdateCatagory(int catagoryId, Catagory catagory)
        {
            if (catagoryId != catagory.CatagoryId)
            { 
                return; 
            }

            var catagoryToUpdate = _catagories.FirstOrDefault(x => x.CatagoryId == catagoryId);

            if (catagoryToUpdate != null)
            {
                catagoryToUpdate.Name = catagory.Name;
                catagoryToUpdate.Description = catagory.Description;
            }
        }

        public static void DeleteCatagory(int catagoryId)
        {
            var catagory = _catagories.FirstOrDefault(x => x.CatagoryId == catagoryId);

            if (catagory != null)
            {
                _catagories.Remove(catagory);
            }
        }
    }
}

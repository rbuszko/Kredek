namespace SklepInternetowy.Models
{
    public class ItemViewModel
    {
        /// <summary>
        /// Konstruktor z parametrami
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="brand"></param>
        /// <param name="description"></param>
        /// <param name="price"></param>
        /// <param name="photoPath"></param>
        public ItemViewModel(int id, string name, string brand, string description, decimal price, string photoPath)
        {
            Id = id;
            Name = name;
            Brand = brand;
            Description = description;
            Price = price;
            PhotoPath = photoPath;
        }
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nazwa przedmiotu
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Marka
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// Opis przedmiotu
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Cena
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Ścieżka do zdjęcia
        /// </summary>
        public string PhotoPath { get; set; }
    }
}

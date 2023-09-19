namespace fa_icon_demo
{
    internal class Skin
    {
        string images_and_storage_id, name, price;
        private byte[] image;

        public Skin()
        {
        }

        public Skin(string images_and_storage_id, string name, string price, byte[] image)
        {
            this.Id = images_and_storage_id;
            this.Name = name;
            this.Price = price;
            this.Image = image;
        }

        public string Id { get => images_and_storage_id; set => images_and_storage_id = value; }
        public string Name { get => name; set => name = value; }
        public string Price { get => price; set => price = value; }
        public byte[] Image { get => image; set => image = value; }
    }
}

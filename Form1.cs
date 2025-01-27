namespace Inventory_Application
{
    public partial class Form1 : Form
    {
        private Inventory inventory = new Inventory();
        private ListBox lstInventory;
        private Button btnShowInventory; // Declare button

        public Form1()
        {
            InitializeComponent();

            // Initialize ListBox
            lstInventory = new ListBox
            {
                Location = new Point(20, 50),
                Size = new Size(300, 200)
            };
            this.Controls.Add(lstInventory);

            // Initialize Button
            btnShowInventory = new Button
            {
                Text = "Show Inventory",
                Location = new Point(20, 270), // Below the ListBox
                Size = new Size(120, 30)
            };
            btnShowInventory.Click += btnShowInventory_Click; // Attach click event
            this.Controls.Add(btnShowInventory);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate inventory
            inventory.AddItem(new Item("Pikachu", "Electric", 0.4, 6.0, "Raichu"));
            inventory.AddItem(new Item("Bulbasaur", "Grass/Poison", 0.7, 6.9, "Ivysaur"));
            inventory.AddItem(new Item("Charmander", "Fire", 0.6, 8.5, "Charmeleon"));
            inventory.AddItem(new Item("Squirtle", "Water", 0.5, 9.0, "Wartortle"));
            inventory.AddItem(new Item("Eevee", "Normal", 0.3, 6.5, "Vaporeon, Jolteon, Flareon"));
        }

        private void btnShowInventory_Click(object sender, EventArgs e)
        {
            // Clear and display inventory
            lstInventory.Items.Clear();
            foreach (var item in inventory.Items)
            {
                lstInventory.Items.Add(item.ToString());
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string EvolutionForm { get; set; }

        public Item(string name, string type, double height, double weight, string evolutionForm)
        {
            Name = name;
            Type = type;
            Height = height;
            Weight = weight;
            EvolutionForm = evolutionForm;
        }

        public override string ToString()
        {
            return $"{Name} - {Type} - {Height}m - {Weight}kg - Evolves into: {EvolutionForm}";
        }
    }

    public class Inventory
    {
        public List<Item> Items { get; private set; } = new List<Item>();

        public void AddItem(Item item)
        {
            Items.Add(item);
        }
    }
}


namespace MusicAppSQL
{
    public partial class Form1 : Form
    {
        BindingSource albumBindingSource = new BindingSource();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDOA albumsDOA = new AlbumsDOA();
            albumBindingSource.DataSource = albumsDOA.getAllAlbums();
            dataGridView1.DataSource = albumBindingSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlbumsDOA albumsDOA = new AlbumsDOA();
            albumBindingSource.DataSource = albumsDOA.searchTitles(textBox1.Text);
            dataGridView1.DataSource = albumBindingSource;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int rowNum = dataGridView.CurrentRow.Index;
            String imageURL = dataGridView.Rows[rowNum].Cells[4].Value.ToString();
            pictureBox1.Load(imageURL);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Album album = new Album
            {
                AlbumName = txt_albumName.Text,
                ArtistName = txt_artist.Text,
                Year = Int32.Parse(txt_year.Text),
                ImageURL = txt_url.Text,
                Description = txt_description.Text
            };

            AlbumsDOA albumsDOA = new AlbumsDOA();
            int result = albumsDOA.addOneAlbum(album);
        }
    }
}
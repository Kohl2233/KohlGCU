namespace MusicAppSQL
{
    public partial class Form1 : Form
    {
        AlbumDatabaseService albumDatabaseService = new AlbumDatabaseService();

        BindingSource albumBindingSource = new BindingSource();
        BindingSource trackBindingSource = new BindingSource();

        List<Album> albums = new List<Album>();

        public Form1()
        {
            InitializeComponent();
        }

        private void updateAlbumGrid()
        {
            albumBindingSource.DataSource = albumDatabaseService.getAllAlbums();
            dataGridView1.DataSource = albumBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateAlbumGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text;
            List<Album> searchResults = albumDatabaseService.searchTitles(searchTerm);

            albumBindingSource.DataSource = searchResults;
            dataGridView1.DataSource = albumBindingSource;

        
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int rowNum = dataGridView.CurrentRow.Index;
            String imageURL = dataGridView.Rows[rowNum].Cells[4].Value.ToString();
            try
            {
                pictureBox1.Load(imageURL);
            }
            catch
            {
                // error
            }

            Album album = albumDatabaseService.getOne((string)dataGridView1.Rows[rowNum].Cells[0].Value);
            trackBindingSource.DataSource = album.Tracks;
            dataGridView2.DataSource = trackBindingSource;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Album album = new Album
            {
                Title = txt_albumName.Text,
                Artist = txt_artist.Text,
                Year = Int32.Parse(txt_year.Text),
                ImageURL = txt_url.Text,
                Description = txt_description.Text
            };

            albumDatabaseService.addOneAlbum(album);
            updateAlbumGrid();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int rowClicked = dataGridView.CurrentRow.Index;
            string videoURL = dataGridView.Rows[rowClicked].Cells[3].Value.ToString();
            webView21.Source = new Uri(videoURL);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridView1.CurrentRow.Index;
            string itemNumber = (string)dataGridView1.Rows[rowClicked].Cells[0].Value;
            int deleteResult = albumDatabaseService.delteOne(itemNumber);
            if (deleteResult < 1) { MessageBox.Show("Error Deleting."); }
            updateAlbumGrid();

        }
    }
}
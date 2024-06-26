namespace MusicAppSQL
{
    public partial class Form1 : Form
    {
        BindingSource albumBindingSource = new BindingSource();
        BindingSource trackBindingSource = new BindingSource();

        List<Album> albums = new List<Album>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDOA albumsDOA = new AlbumsDOA();
            albums = albumsDOA.getAllAlbums();
            albumBindingSource.DataSource = albums;
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
            try
            {
                pictureBox1.Load(imageURL);
            }
            catch
            {
                // error
            }

            AlbumsDOA albumsDOA = new AlbumsDOA();
            trackBindingSource.DataSource = albumsDOA.getTracksForAlbum(rowNum + 1);
            dataGridView2.DataSource = trackBindingSource;
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

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int rowClicked = dataGridView.CurrentRow.Index;
            string videoURL = dataGridView.Rows[rowClicked].Cells[3].Value.ToString();
            webView21.Source = new Uri(videoURL);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridView2.CurrentRow.Index;
            MessageBox.Show("You clicked row: " + rowClicked);
            int trackID = (int)dataGridView2.Rows[rowClicked].Cells[0].Value;
            MessageBox.Show("ID of track: " + trackID);

            AlbumsDOA albumsDOA = new AlbumsDOA();
            int result = albumsDOA.deleteTrack(trackID);
            MessageBox.Show("Result: " + result);
        }
    }
}
namespace crud_murid.Models
{
    public class Murid
    {
        public int id_murid { get; set; }
        public string? nama { get; set; }
        public string? alamat { get; set; }
        public string? email { get; set; }
    }

}

// Ini buat databasenya kalau mau mencoba //

//CREATE TABLE murid (
//id_murid SERIAL PRIMARY KEY,
//nama VARCHAR(100),
//alamat VARCHAR(255),
//email VARCHAR(100)
//);

//INSERT INTO murid (nama, alamat, email) VALUES
//('Faith Reyhan', 'Mastrip', 'faithreyhan@gmail.com'),
//('Elian Waluyo', 'Kaliurang', 'elianwaluyo@gmail.com'),
//('Sehat Abadi', 'Sumbersari', 'sehatabadi@gmail.com');

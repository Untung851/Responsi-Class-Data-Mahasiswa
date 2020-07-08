using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();
                
                Console.WriteLine("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                    Console.Clear();
                    Console.WriteLine(" Silahkan Menu yang tersedia ");
                    Console.ReadKey();
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine(" UNTUNG DWI HANDOKO 19.11.2820 ");
            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Mahasiswa ");
            Console.WriteLine("2. Hapus Mahasiswa ");
            Console.WriteLine("3. Tampilkan Mahasiswa ");
            Console.WriteLine("4. Keluar");

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahMahasiswa()
        {
            Console.Clear();
            Console.Clear();
            Mahasiswa mahasiswa = new Mahasiswa();
            Console.WriteLine("Tambah Data Mahasiswa\n");
            Console.Write("NIM : ");
            mahasiswa.nim = Console.ReadLine();
            Console.Write("Nama : ");
            mahasiswa.nama = Console.ReadLine();
            Console.Write("Jenis Kelamin [L/P] : ");
            mahasiswa.jeniskelamin = Console.ReadLine();
            if (mahasiswa.jeniskelamin == "L")
            {
                mahasiswa.jeniskelamin = "Laki-Laki";
            }
            else if (mahasiswa.jeniskelamin == "P")
            {
                mahasiswa.jeniskelamin = "Perempuan";
            }
            else
            {
                mahasiswa.jeniskelamin = "Jenis Kelamin Tidak Teridentifikasi";
            }
            Console.Write("IPK : ");
            mahasiswa.ipk = Console.ReadLine();
            daftarMahasiswa.Add(mahasiswa);
            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMahasiswa()
        {
            Console.Clear();
            int no = -1, del = -1;
            Console.WriteLine("Hapus Data Mahasiswa\n");
            Console.Write("NIM : ");
            int nim = int.Parse(Console.ReadLine());
            foreach (Mahasiswa mahasiswa in daftarMahasiswa)
            {
                no++;
                if (nim == nim)
                {
                    del = no;
                }
            }
            if (del != -1)
            {
                daftarMahasiswa.RemoveAt(del);
                Console.WriteLine("\nData mahasiswa berhasil di hapus");
            }
            else
            {
                Console.WriteLine("\nNIM tidak ditemukan");
            }

            // PERINTAH: lengkapi kode untuk menghapus objek mahasiswa dari dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();
            int no = 0;
            Console.WriteLine("Data Mahasiswa\n");
            foreach (Mahasiswa mahasiswa in daftarMahasiswa)
            {
                no++;
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}", no, mahasiswa.nim, mahasiswa.nama, mahasiswa.jeniskelamin, mahasiswa.ipk);
            }
            if (no < 1)
            {
                Console.WriteLine("Data Mahasiswa Kosong");
            }

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}

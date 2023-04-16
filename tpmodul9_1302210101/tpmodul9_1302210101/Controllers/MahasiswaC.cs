using Microsoft.AspNetCore.Mvc;

namespace tpmodul9_1302210101.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MahasiswaC : ControllerBase
    {
        public static List<Mahasiswa> mhs = new List<Mahasiswa>
    {
        new Mahasiswa ("Maximus Bayu", "1302210101"),
        new Mahasiswa ("Adam Rafif Faqih", "1302210008"),
        new Mahasiswa ("Habli Zulvana Ath-Thaariq", "1302210024"),
        new Mahasiswa ("Muhammad Isa Al Anshori", "1302210014"),
        new Mahasiswa ("Muhamad Ilham Nasrullah", "1302210041")
    };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mhs;
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa addMahasiswa)
        {
            mhs.Add(addMahasiswa);
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mhs[id];
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mhs.RemoveAt(id);
        }
    }
}

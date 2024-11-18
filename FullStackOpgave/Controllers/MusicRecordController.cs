using Microsoft.AspNetCore.Mvc;

namespace FullStackOpgave.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicRecordController : ControllerBase
    {
        private MusicRecordRepo _musicRecordRepo;



        public MusicRecordController(MusicRecordRepo musicRecord)
        {
            _musicRecordRepo = musicRecord;

        }

        // GET: api/<TeachersController>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public ActionResult<IEnumerable<MusicRecord>> Get()
        {

            var musicRecords = _musicRecordRepo.GetAll();
            if (musicRecords != null && musicRecords.Count() != 0)
            {
                return Ok(musicRecords);
            }
            else
                return NotFound(musicRecords);



        }
    }
}

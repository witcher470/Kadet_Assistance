using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataTier.Entities.Abstract;
using DataTier.Entities.Concrete;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly EFDbContext _context;

        public CardsController(EFDbContext context)
        {
            _context = context;
        }

        // GET: api/Cards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Card>>> GetCards()
        {
            return await _context.Cards.ToListAsync();
        }

        // GET: api/Cards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Card>> GetCard(int id)
        {
            var card = await _context.Cards.FindAsync(id);

            if (card == null)
            {
                return NotFound();
            }

            return card;
        }
        [HttpGet]
        public IActionResult SearchByFristName(string searchString)
        {
            var cards = from cd in _context.Cards
                        select cd;
            IQueryable<ClientInfo> clientinfos = from ci in _context.ClientInfos
                                                 select ci;

            if (!String.IsNullOrEmpty(searchString))
            {
                cards = cards.Where(ci => ci.ClientId == ci.ClientInfo.Id).Where(ci => ci.ClientInfo.ClientFristName.Contains(searchString));
            }

            return Ok(cards);
        }
        [HttpGet]
        public IActionResult SearchBySecondName(string searchString)
        {
            var cards = from cd in _context.Cards
                        select cd;
            IQueryable<ClientInfo> clientinfos = from ci in _context.ClientInfos
                                                 select ci;

            if (!String.IsNullOrEmpty(searchString))
            {
                cards = cards.Where(ci => ci.ClientId == ci.ClientInfo.Id).Where(ci => ci.ClientInfo.ClientSecondName.Contains(searchString));
            }

            return Ok(cards);
        }
        [HttpGet]
        public IActionResult SearchByThirdName(string searchString)
        {
            var cards = from cd in _context.Cards
                        select cd;
            IQueryable<ClientInfo> clientinfos = from ci in _context.ClientInfos
                                                 select ci;

            if (!String.IsNullOrEmpty(searchString))
            {
                cards = cards.Where(ci => ci.ClientId == ci.ClientInfo.Id).Where(ci => ci.ClientInfo.ClientThirdName.Contains(searchString));
            }

            return Ok(cards);
        }
        [HttpGet]
        public IActionResult SearchByVIN(string searchString)
        {
            var cards = from cd in _context.Cards
                        select cd;

            if (!String.IsNullOrEmpty(searchString))
            {
                cards = cards.Where(cd => cd.VIN.Contains(searchString));
            }

            return Ok(cards);
        }
        [HttpGet]
        public IActionResult SearchByCardNumber(string searchString)
        {
            var cards = from cd in _context.Cards
                        select cd;

            if (!String.IsNullOrEmpty(searchString))
            {
                cards = cards.Where(cd => cd.CardNumber.Contains(searchString));
            }

            return Ok(cards);
        }
        public IActionResult SearchByStateNumber(string searchString)
        {
            var cards = from cd in _context.Cards
                        select cd;
            IQueryable<ClientInfo> clientinfos = from ci in _context.ClientInfos
                                            select ci;

            if (!String.IsNullOrEmpty(searchString))
            {
                cards = cards.Where(ci => ci.ClientId == ci.ClientInfo.Id).Where(ci => ci.ClientInfo.StateNumber.Contains(searchString));
            }

            return Ok(cards);
        }
        [HttpGet]
        public IActionResult GetActiveCards()
        {
            var cards = _context.Cards.Where(cs => cs.CardStatus == CardStatus.active);
            return Ok(cards);
        }
        [HttpGet]
        public IActionResult GetInactiveCards()
        {
            var cards = _context.Cards.Where(cs => cs.CardStatus == CardStatus.inactive);
            return Ok(cards);
        }

        // PUT: api/Cards/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCard(int id, Card card)
        {
            if (id != card.Id)
            {
                return BadRequest();
            }

            _context.Entry(card).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CardExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Cards
        [HttpPost]
        public async Task<ActionResult> PostCard(PostCardsModel model)
        {
            var card = new Card()
            {
                CardNumber = model.CardNumber,
                CardCost = model.CardCost,
                ClientId = model.ClientId,
                ClientInfo = model.ClientInfo,
                Duration = model.Duration,
                VIN = model.VIN,
                Color = model.Color,
                Services = model.Services,
                SellerFirstName = model.SellerFirstName,
                SellerSecondName = model.SellerSecondName,
                SellerThirdName = model.SellerThirdName,
                NumberOfContractWithKadet = model.NumberOfContractWithKadet,
                DateOfContractWithKadet = model.DateOfContractWithKadet,
                NumberOfContractWithClient = model.NumberOfContractWithClient,
                DateOfContractWithClient = model.DateOfContractWithClient,
                ActionStartDate = model.ActionStartDate,
                ManagerFirstName = model.ManagerFirstName,
                ManagerSecondName = model.ManagerSecondName,
                ManagerThirdName = model.ManagerThirdName,
                CardStatus = model.CardStatus,
                DeactivationDate = model.DeactivationDate,
                CardAppeal = model.CardAppeal,
                EmployerFirstName = model.EmployerFirstName,
                EmployerSecondName = model.EmployerSecondName,
                EmployerThirdName = model.EmployerThirdName
            };
            _context.Cards.Add(card);
            await _context.SaveChangesAsync();

            return Ok();
        }

    // DELETE: api/Cards/5
    [HttpDelete("{id}")]
        public async Task<ActionResult<Card>> DeleteCard(int id)
        {
            var card = await _context.Cards.FindAsync(id);
            if (card == null)
            {
                return NotFound();
            }

            _context.Cards.Remove(card);
            await _context.SaveChangesAsync();

            return card;
        }

        private bool CardExists(int id)
        {
            return _context.Cards.Any(e => e.Id == id);
        }
    }
}

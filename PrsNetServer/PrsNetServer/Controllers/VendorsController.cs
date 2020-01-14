using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrsNetServer.Models;

namespace PrsNetServer.Controllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class VendorsController : ControllerBase {
        private static AppDbContext _context = null;
        public VendorsController(AppDbContext context) {
            _context = context;
            }
        [HttpGet]
        public async Task<IEnumerable<Vendor>> GetAllVendors() {
            return await _context.Vendors.ToListAsync();
            }
        [HttpGet("{id}")]
        public async Task<ActionResult<Vendor>> GetByPK(int id) {
            var ven = await _context.Vendors.FindAsync(id);
            if (ven == null) return NotFound();
            return new OkObjectResult(ven);
            }
        [HttpPost]
        public async Task<IActionResult> Insert(Vendor ven) {
            if (ven == null) return new BadRequestResult();
            _context.Vendors.Add(ven);
            await _context.SaveChangesAsync();
            return new OkObjectResult();
            }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Vendor ven, int id) {
            if (ven == null||ven.Id !== id) return new BadRequestResult();
            _context.Entry(ven).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return new OkObjectResult();
            }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Vendor>> DeleteByPk(int id) {
            var ven = await _context.Vendors.FindAsync(id);
            if (ven == null) return NotFound();
            _context.Vendors.Remove(ven);
            await _context.SaveChangesAsync();
            return new OkObjectResult();
            }

        }
    }
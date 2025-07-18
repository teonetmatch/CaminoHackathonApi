﻿using CaminoHackathonApi.Models;
using CaminoHackathonApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CaminoHackathonApi.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class AccommodationController : ControllerBase
	{
		private readonly IAccommodationSearchService _searchSvc;

		public AccommodationController(IAccommodationSearchService searchSvc)
		{
			_searchSvc = searchSvc;
		}

		[HttpPost("search")]
		public async Task<IActionResult> Search([FromBody] AccommodationSearchRequestDto dto)
		{
			var grpcResp = await _searchSvc.SearchAsync(dto);
			return Ok(grpcResp);
		}
	}
}
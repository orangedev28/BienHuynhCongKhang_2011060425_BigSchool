using BienHuynhCongKhang_2011060425_Week3.DTOs;
using BienHuynhCongKhang_2011060425_Week3.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BienHuynhCongKhang_2011060425_Week3.Controllers
{
    public class FollowingsController : ApiController
    {
        private readonly ApplicationDbContext dbContext;

        public FollowingsController()
        {
            dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Follow(FollowingDto followingDto)
        {
            var userId = User.Identity.GetUserId();
            if (dbContext.Followings.Any(f => f.FollowerId == userId && f.FollowerId == followingDto.FolloweeId))
                return BadRequest("Following already exists!");

            var following = new Following
            {
                FollowerId = userId,
                FolloweeId = followingDto.FolloweeId,
            };

            dbContext.Followings.Add(following);
            dbContext.SaveChanges();

            return Ok();
        }
    }
}

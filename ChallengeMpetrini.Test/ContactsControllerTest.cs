using AutoMapper;
using ChallengeMpetrini.Api.Contracts;
using ChallengeMpetrini.Api.Controllers;
using ChallengeMpetrini.Api.DTOs;
using ChallengeMpetrini.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ChallengeMpetrini.Test
{
    public class ContactsControllerTest
    {
        private readonly Mock<IService<Contact>> _mockService;
        private readonly Mock<IMapper> _mockMapper;
        private readonly ContactsController _controller;

        public ContactsControllerTest()
        {
            IEnumerable<Contact> list = new List<Contact>();
            IEnumerable<ContactDto> listDto = new List<ContactDto>() {
                new ContactDto
                {
                    Name = "Mauro Petrini",
                    Company = "Company name",
                    Profile_Image = "https://s3.amazonaws.com/technical-challenge/v3/images/miss-piggy-small.jpg",
                    Email = "dev.mpetrini@gmail.com",
                    Birthdate = new DateTime(1992, 8, 24),
                    Phone = new PhoneDto {
                        Home=  "4288-4483",
                        Work=  "4288-2123",
                        Mobile= "1122-1234"
                    },
                    Address = new AddressDto {
                        Street = "Rot 2391"
                    }
                }
            };

            _mockService = new Mock<IService<Contact>>();
            _mockService.Setup(s => s.GetAll(null, p => p.City, p => p.City.State)).Returns(list);

            _mockMapper = new Mock<IMapper>();
            _mockMapper.Setup(m => m.Map<IEnumerable<ContactDto>>(list)).Returns(listDto);

            _controller = new ContactsController(_mockService.Object, _mockMapper.Object);
        }

        [Fact]
        public void Get_All_ReturnsOkResult()
        {
            IActionResult result = _controller.GetAll();
            OkObjectResult resultOk = result as OkObjectResult;
            BadRequestObjectResult result400 = result as BadRequestObjectResult;

            IEnumerable<ContactDto> values = resultOk.Value as IEnumerable<ContactDto>;

            Assert.NotNull(result);
            Assert.NotNull(resultOk);
            Assert.Null(result400);

            Assert.Equal(200, resultOk.StatusCode);
            Assert.False(resultOk.StatusCode == 400);

            Assert.NotNull(values);
            Assert.True(values.Any());
        }
    }
}

﻿using CleanArchitecture_Demo.Domain.Entities;
using CleanArchitecture_Demo_Application.Common.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CleanArchitecture_Demo_Application.Features.Players.Queries.GetPlayersWithPagination
{
    public class GetPlayersWithPaginationDto : IMapFrom<Player>
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public int ShirtNo { get; init; }
        public int HeightInCm { get; init; }
        public string FacebookUrl { get; init; }
        public string TwitterUrl { get; init; }
        public string InstagramUrl { get; init; }
        public int DisplayOrder { get; init; }
    }
}

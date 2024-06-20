using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Features.Roles.GetRole;

public sealed record GetRolesQuery() : IRequest<List<GetRolesQueryResponse>>;
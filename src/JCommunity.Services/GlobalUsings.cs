﻿global using FluentResults;
global using FluentValidation;
global using JCommunity.AppCore.Core.Abstractions;
global using JCommunity.AppCore.Core.Errors;
global using JCommunity.AppCore.Entities.File;
global using JCommunity.AppCore.Entities.MemberAggregate;
global using JCommunity.AppCore.Entities.PostAggregate;
global using JCommunity.AppCore.Entities.TopicAggregate;
global using JCommunity.Infrastructure.Repository;
global using JCommunity.Services.FileService;
global using JCommunity.Services.MemberService.Dtos;
global using JCommunity.Services.ServiceBehaviors;
global using MediatR;
global using Microsoft.AspNetCore.Http;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using System.Reflection;

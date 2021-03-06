﻿using AutoMapper;
using Mbp.Ddd.Application.Mbp.UI;
using Mbp.EntityFrameworkCore.PermissionModel;
using Medical.Ai.Mbdp.Application.Contracts.AccountService.Dto;
using Medical.Ai.Mbdp.Application.Contracts.Demo.Dto;
using Medical.Ai.Mbdp.Application.Contracts.LogService.Dto;
using Medical.Ai.Mbdp.Domain.DomainEntities.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Ai.Mbdp.Application
{
    /// <summary>
    /// object to object Map
    /// </summary>
    public static class AutoMapperConfig
    {
        public static IMapper CreateMapper()
        {
            // TO DO 在这里注册所有的类型映射cfg.CreateMap<TSource, TDestination>()
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Blog, BlogDto>();
                cfg.CreateMap<Post, PostDto>();

                cfg.CreateMap<BlogDto, Blog>();
                cfg.CreateMap<PostDto, Post>();

                // 用户映射
                cfg.CreateMap<UserInputDto, MbpUser>();
                cfg.CreateMap<MbpUser, UserOutputDto>();

                // 角色映射
                cfg.CreateMap<RoleInputDto, MbpRole>();
                cfg.CreateMap<MbpRole, RoleOutputDto>();

                // 菜单映射
                cfg.CreateMap<MenuInputDto, MbpMenu>();
                cfg.CreateMap<MbpMenu, MenuOutputDto>();

                // 日志映射
                cfg.CreateMap<LogInputDto, MbpOperationLog>();
                cfg.CreateMap<MbpOperationLog, LogOutInputDto>();

            });

            return config.CreateMapper();
        }
    }
}

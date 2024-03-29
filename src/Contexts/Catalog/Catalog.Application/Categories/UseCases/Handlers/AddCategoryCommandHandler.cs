﻿using AutoMapper;
using BuildingBlocks.Core.Utils;
using Catalog.Application.Categories.UseCases.Commands;
using Catalog.Domain.Entities.Categories;
using MediatR;

namespace Catalog.Application.Categories.UseCases.Handlers
{
    public class AddCategoryCommandHandler : IRequestHandler<AddCategoryCommand, Result>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public AddCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<Result> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Category>(request.addCategoryDto);

            await _categoryRepository.AddProductAsync(category);

            return Result.Success();
        }
    }
}

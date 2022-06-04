using Application.UseCases.Update.Update.DataAcess;

using Domain.Entity;
using Domain.Mappers;

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Segment.Update
{
    public class UpdateSegmentUseCase : IUpdateSegmentUseCase
    {
        private readonly IUpdateSegmentUseCaseRepository _updateSegmentUseCaseRepository;

        public UpdateSegmentUseCase(IUpdateSegmentUseCaseRepository updateSegmentUseCaseRepository)
        {
            _updateSegmentUseCaseRepository = updateSegmentUseCaseRepository;
        }

        public async Task ExecuteAsync(UpdateSegmentUseCaseInput input, CancellationToken cancellationToken)
        {
            var ids = input.Segments.Select(segment => segment._id);

            var oldSegments = await _updateSegmentUseCaseRepository.GetById(ids);
            var updatedSegments = input.Segments.MapToEntity();

            var mapUpdatedSegments = updatedSegments.GroupBy(x => x._id).ToDictionary(keySelector => keySelector.Key, comparer => comparer.FirstOrDefault());

            foreach (var oldSegment in oldSegments)
            {
                var updatedSegment = mapUpdatedSegments[oldSegment._id];
                updatedSegment.Feedbacks.ForEach(feedback => feedback.UserId = input.UserId);
                oldSegment.Feedbacks.AddRange(updatedSegment.Feedbacks);
                oldSegment.ProcessAverage();
            }

            await _updateSegmentUseCaseRepository.Update(oldSegments);
        }
    }
}
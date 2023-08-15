
using AutoMapper;
using Notes.Application.Common.Mappings;
using Notes.Domain;

namespace Notes.Application.Notes.Queries.GetNoteDetails
{
    public class NoteDetailsVm : IMapWith<Note>
    { 
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EditDate { get; set; }

        public void Mapping(Profile profile) 
        {
             profile.CreateMap<Note, NoteDetailsVm>()
                .ForMember(n => n.Title, o => o.MapFrom(note => note.Title))
                .ForMember(n => n.Details, o => o.MapFrom(note => note.Details))
                .ForMember(n => n.Id, o => o.MapFrom(note => note.Id))
                .ForMember(n => n.CreationDate, o => o.MapFrom(note => note.CreationDate))
                .ForMember(n => n.EditDate, o => o.MapFrom(note => note.EditDate));
        }
    }
}

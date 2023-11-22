using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Notes.Queries.GetNoteList
{
    public class NoteListVm
    {
        public IList<NoteLookupDto> Notes { get; set; }

        public static explicit operator NoteListVm(List<NoteLookupDto> v)
        {
            throw new NotImplementedException();
        }
    }
}

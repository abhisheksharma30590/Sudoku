using Sudoku.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Common.Data
{
    public interface IProblemRepository
    {
        void AddProblemStatement(SudokuModel model);
    }
}

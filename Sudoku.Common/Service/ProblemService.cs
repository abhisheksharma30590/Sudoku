using Sudoku.Common.Data;
using Sudoku.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Common.Service
{
    public class ProblemService
    {
        ProblemRepository _problemRepository = new ProblemRepository();

        public int AddProblemStatement(SudokuModel model)
        {
            try
            {
                _problemRepository.AddProblemStatement(model);
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public List<SudokuModel> ProblemList()
        {
            try
            {
                return _problemRepository.ProblemList();
            }
            catch (Exception ex)
            {
                return new List<SudokuModel>();
            }
        }

        public SudokuModel GetProblemByProblemId(string problemId)
        {
            try
            {
                return _problemRepository.GetProblemByProblemId(problemId);
            }
            catch (Exception ex)
            {
                return new SudokuModel();
            }
        }

        public int GetProblemsCount()
        {
            try
            {
                return _problemRepository.GetProblemsCount();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}

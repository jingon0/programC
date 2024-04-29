using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csbemt
{
    public class ReadData
    {
        public void Print_dat(string file_path)
        {
            try
            {
                // FileStream을 사용하여 파일 열기
                using (FileStream fs = new FileStream(file_path, FileMode.Open))
                {
                    // StreamReader를 사용하여 파일 읽기
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line;

                        while ((line = sr.ReadLine()) != null)
                            Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                // 오류 처리
                Console.WriteLine("파일을 읽는 도중 오류가 발생했습니다: " + ex.Message);
            }
       }

        static string ConsolidateSpaces(string input)
        {
            // 공백을 기준으로 문자열 분할
            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            // 분할된 부분을 다시 합침
            return string.Join(" ", parts);
        }
    }
}

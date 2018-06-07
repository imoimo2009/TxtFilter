using System;

namespace TxtFilter
{
    static class Constants
    {
        public const int SEARCH_KEY = 0;
        public const int INFILE_NAME = 1;
        public const int OUTFILE_NAME = 2;

        public const string FILEDLG_TITLE = "入力ファイルを開く";
        public const string FILEDLG_FILTER = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

        public const char SEARCH_DELIMITER = ' ';

        public const string COMPLETE_MSG = "抽出完了！";
    }
}

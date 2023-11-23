using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duan2
{
    public enum FIELD { FLD_EMPTY = ' ', FLD_X = 'X', FLD_O = 'O' }
    internal class Cell
    {
        //Xac dinh gia tri tung o co [null, X, O]
        
            FIELD fieldstate = FIELD.FLD_EMPTY;
            //Khoi tao mac dinh o co la null
            public Cell(FIELD fieldstate = FIELD.FLD_EMPTY)
            {
                this.fieldstate = fieldstate;
            }

            internal FIELD Fieldstate { get => fieldstate; set => fieldstate = value; }
            //kiem tra o co dang rong~
            public bool isEmpty()
            {
                return (fieldstate == FIELD.FLD_EMPTY);
            }
            public void markField(char c) // dien dau nguoi nguoi choi vao o
            {
         
            if (c == 'X')
                
                fieldstate = FIELD.FLD_X;
                else if(c == 'O')
                fieldstate = FIELD.FLD_O;
                else fieldstate = FIELD.FLD_EMPTY;
            }


    }
}

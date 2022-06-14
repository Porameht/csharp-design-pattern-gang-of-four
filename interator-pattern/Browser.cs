using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interator_pattern
{
     public class Browser
    {
        private BrowserHistory[] _histories;
        // private List<BrowserHistory> _histories;
        // public List<BrowserHistory> Histories => _histories;
        private int _index;
        public Browser()
        {
            _histories = new BrowserHistory[10];
            // _histories = new List<BrowserHistory>();
            _index = 0;
        }

        public void PushHistory(BrowserHistory history){
            _histories[_index] = (history);
            // _histories.Add(history);
            _index += 1;
        }

        public BrowserHistory PopHistory(){
            var lastElement = _histories[_index];
            _histories[_index] = null;
            // _histories.RemoveAt(_index);
            _index -= 1;
            return lastElement;
        }

        public Iterator<BrowserHistory> CreateIterator()
        {
            return new ArrayIterator(this);
            // return new ListIterator(this);

        }

        public class ArrayIterator : Iterator<BrowserHistory>
        {
            private readonly Browser _browser;
            private int _index;
            public ArrayIterator(Browser browser)
            {
                _browser = browser;
                _index = 0;
            }

            public BrowserHistory Current()
            {
                return _browser._histories[_index];
            }

            public bool HasNext()
            {
                return _index < _browser._index;
            }

            public void Next()
            {
                _index ++;
            }
        }
        // public class ListIterator : Iterator<BrowserHistory>
        // {
        //     private readonly Browser _browser;
        //     private int _index;
        //     public ListIterator(Browser browser)
        //     {
        //         _browser = browser;
        //         _index = 0;
        //     }

        //     public BrowserHistory Current()
        //     {
        //         return _browser._histories[_index];
        //     }

        //     public bool HasNext()
        //     {
        //         return _index < _browser._histories.Count;
        //     }

        //     public void Next()
        //     {
        //         _index +=1;
        //     }
        // }


    }
}
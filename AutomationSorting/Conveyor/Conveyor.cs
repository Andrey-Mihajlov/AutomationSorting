using AutomationSorting.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationSorting.ConveyorProcessing
{
    public class Conveyor
    {
        ScanProcessor _scanProcessor = new ScanProcessor();
        PrintProcessor _printProcessor = new PrintProcessor();
        CheckinProcessor _checkinProcessor = new CheckinProcessor();
        SortingProcessor _sortingProcessor = new SortingProcessor();
        LoggingProcessor _loggingProcessor = new LoggingProcessor();

        public void Process(int index, long startProcessingTime)
        {
            ProcessingUnit unit = new AutomationSorting.ConveyorProcessing.ProcessingUnit();
            unit.StartProcessingTime = startProcessingTime;

            _scanProcessor.Start(unit);
            Thread.Sleep(ConveyorHelper.ScanDelay);
            _scanProcessor.Complete();

            _checkinProcessor.Process(unit);
            _printProcessor.Process(unit);
            _sortingProcessor.Process(unit);
            _loggingProcessor.Process(unit);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Home_Cinema___Facade_Pattern
{
    public class HomeCinemaFacade
    {
        DvdPlayer _dvdPlayer;
        Screen _screen;
        PopcornPopper _popcornPopper;

        public HomeCinemaFacade(DvdPlayer dvdPlayer, Screen screen, PopcornPopper popcornPopper)
        {
            _dvdPlayer = dvdPlayer;
            _screen = screen;
            _popcornPopper = popcornPopper;
        }

        public void WatchFilm()
        {
            _popcornPopper.On();
            _popcornPopper.Pop();
            _screen.Down();
            _dvdPlayer.Play();
        }

        public void EndFilm()
        {
            _dvdPlayer.Stop();
            _screen.Up();
            _popcornPopper.Off();
        }
    }
}

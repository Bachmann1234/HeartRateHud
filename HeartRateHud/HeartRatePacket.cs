namespace HeartRateApp
{
    internal class HeartRatePacket
    {
        private readonly byte[] _hrPacket = new byte[5];
        private int _hrPacketIndex;


        public string SetByte(byte b)
        {
            if ((b & 0x80) != 0)
            {
                if (_hrPacketIndex == _hrPacket.Length && (_hrPacket[0] & (0x80)) != 0)
                {
                    var hrReading = this.read();
                    reset();
                    return hrReading;
                }
                reset();

            }

            if (_hrPacketIndex < _hrPacket.Length)
            {
                _hrPacket[_hrPacketIndex] = b;
                _hrPacketIndex += 1;
            }
            return null;
        }

        public void reset()
        {
            for (var i = 0; i < _hrPacket.Length; i++)
            {
                _hrPacket[i] = 0;
            }
            _hrPacketIndex = 0;
        }
       

        public string read()
        {
            var pulseRate = (_hrPacket[2] & 0x40) << 1;
            pulseRate |= _hrPacket[3] & 0x7f;
            return pulseRate.ToString();
        }


    }
}

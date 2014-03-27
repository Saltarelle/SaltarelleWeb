[NoInterfaceObject]
interface RandomSource {
  [Throws]
  ArrayBufferView getRandomValues(ArrayBufferView array);
};

Crypto implements RandomSource;

interface Crypto {
};


public class ClassArray<T extends IAnimal> {
	private T[] places;
	private T defaultValue;

	@SuppressWarnings("unchecked")
	public ClassArray(int sizes, T defVal) {
		defaultValue = defVal;
		places = (T[]) new IAnimal[sizes];
		for (int i = 0; i < places.length; i++) {
			places[i] = defaultValue;
		}
	}

	public T getObject(int ind) {
		if (ind > -1 && ind < places.length) {
			return places[ind];
		}
		return defaultValue;
	}

	public static <T extends IAnimal> int plus(ClassArray<T> p, T ianimal) {
		for (int i = 0; i < p.places.length; i++) {
			if (p.CheckFreePlace(i)) {
				p.places[i] = ianimal;
				return i;
			}
		}
		return -1;
	}

	public static <T extends IAnimal> T minus(ClassArray<T> p, int index) {
		if (!p.CheckFreePlace(index)) {
			T ianimal = p.places[index];
			p.places[index] = p.defaultValue;
			return ianimal;
		}
		return p.defaultValue;
	}

	private boolean CheckFreePlace(int index) {
		if (index < 0 || index > places.length) {
			return false;
		}
		if (places[index] == null) {
			return true;
		}
		if (places[index].equals(defaultValue)) {
			return true;
		}

		return false;
	}
}

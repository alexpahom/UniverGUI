#pragma once

#ifdef GOODS_EXPORTS
#define GoodAPI __declspec(dllexport)
#else
#define GoodAPI __declspec(dllimport)
#endif // GOOD_EXP
#include <string>
#include <vector>

class GoodAPI Good
{
	int id;
	std::string type, model, manufacturer;
public:
	// Constructors
	Good();
	Good(int id, std::string type, std::string model, std::string manufacturer);
	Good* Create();
	Good* Create(int id, std::string type, std::string model, std::string manufacturer);
	void Dispose();

	// Setters
	void setId(int id);
	void setType(std::string type);
	void setModel(std::string model);
	void setManufacturer(std::string manufacturer);

	// Getters
	int getId();
	std::string getType();
	std::string getModel();
	std::string getManufacturer();

	// Serialization method
	template<class Archive>
	void serialize(Archive &archive);
};
//-----------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------

template<typename ValueType>
class GoodAPI GoodIterator : public std::iterator<std::input_iterator_tag, ValueType>
{
	ValueType* p;
public:
	GoodIterator(ValueType* p);
	GoodIterator(typename std::vector<ValueType>::iterator it);

	bool operator==(GoodIterator<ValueType> const &other) const;
	bool operator!=(GoodIterator<ValueType> const &other) const;
	ValueType operator*() const;
	ValueType* const operator->() const;
	GoodIterator &operator++();
};

//-----------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------

class GoodAPI GoodContainer
{
	std::vector<Good> goods;
public:
	typedef GoodIterator<Good> iterator;
	iterator begin();
	iterator end();

	std::vector<Good> getGoods();

	GoodContainer* add(Good good);
	GoodContainer* drop(int index);
	Good find_by_id(int id);

	void save();
	void load();
};

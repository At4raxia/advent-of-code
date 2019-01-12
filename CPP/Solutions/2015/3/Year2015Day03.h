#ifndef CPP_YEAR2015DAY03_H
#define CPP_YEAR2015DAY03_H

#include "../../../Common/Challenge.h"

class Year2015Day03 : public Challenge {
public:
    auto parse();
    std::string part1() override;
    std::string part2() override;
    explicit Year2015Day03(std::vector<std::string>);
private:
    std::vector<std::string> input;
};

#endif //CPP_YEAR2015DAY03_H
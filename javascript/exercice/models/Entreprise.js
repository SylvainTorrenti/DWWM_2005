const Employee = require('./Employee.js');

/**
 * Gestion d'employés
 */
class Enterprise {
    constructor() {
        this.employees = [];
    }
    isValid(_employee) {


        if (!(_employee instanceof Employee)) {
            return false;
        }

        return true;
    }
    /**
     * 
     * @param  _filter 
     */
    readAll(_filter) {
        return this.employees.filter(_filter);
    }

    /**
     * Créer un employé
     * @param Employee _employee 
     */
    create(_employee) {
        if (this.isValid(_employee)) {



            this.employees.push(_employee);
        }

        return _employee;
    }
    read(_id) {

        let emp = this.employees.find(emp => emp.id === parseInt(_id));

        if (emp !== undefined) {
            let clone = Object.assign(new Employee(), emp);
            return clone;
        }

        return undefined;
    }
    /**
     * Met à jour un employé
     * @param Employee _employee 
     */
    update() {

    }

    /**
     * Supprime un employé
     * @param int _id 
     */
    delete(_id) {
        for (let i = 0; i < this.employees.length; i++) {
            if (this.employees[i].id == _id) {
                this.employees.splice(i, 1);
                return;

            }
        }

    }



    /**
     * Augmentation du salaire
     */
    getHigherSalary(_employee, _newSalary) {
        if (_newSalary > _employee.salary) {
            _employee.salary = _newSalary;
        }
    }

    /**
     * Diminution du salaire
     */
    getLowerSalary(_employee, _newSalary) {
        if (_newSalary < _employee.salary) {
            _employee.salary = _newSalary;
        }
    }

    /**
     * 
     */
    getSalaryGap(_employeeA, _employeeB) {
        let diff;
        if (_employeeA.salary == _employeeB.salary) {
            return "Ces deux employés perçoivent le même salaire";
        }
        if (_employeeA.salary > _employeeB.salary) {
            diff = _employeeA.salary - _employeeB.salary;
            return _employeeA.firstname + " perçoit " + diff + "€/an de plus que " + _employeeB.firstname;
        }
        if (_employeeB.salary > _employeeA.salary) {
            diff = _employeeB.salary - _employeeA.salary;
            return _employeeB.firstname + " perçoit " + diff + "€/an de plus que " + _employeeA.firstname;
        }
    }







}


module.exports = Enterprise;


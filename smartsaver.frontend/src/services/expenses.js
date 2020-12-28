import { ActionCreators } from '../app/expensesReducer';
import * as axios from 'axios';

const axiosInstance = axios.create({
    baseURL: 'https://localhost:44320/Expenses',
})

export const GetExpenses = async (dispatch) => {
    try {
        // API call
        const { data } = await axiosInstance.get();
        dispatch(ActionCreators.setExpenses(data));
    } catch {
        console.log('Error!')
    }
}

export const NewExpense = async (dispatch, expense) => {
    try {
        // API call
        const { data } = await axiosInstance.post('', expense);
        dispatch(ActionCreators.newExpense(data));
    } catch {
        console.log('Error!');
    }
}

export const EditExpense = async (dispatch, expense) => {
    try {
        // API call
        await axiosInstance.put('', expense);
        dispatch(ActionCreators.editExpense(expense));
    } catch {
        console.log('Error!');
    }
}

export const DeleteExpense = async (dispatch, expense) => {
    try {
        // API call
        await axiosInstance.delete('', { data: { ...expense} });
        dispatch(ActionCreators.deleteExpense(expense));
    } catch {
        console.log('Error!');
    }
}
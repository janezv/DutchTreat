import axios from "axios"
import { CompanySearch } from "./company"

interface SearchResponse{
    data: CompanySearch[]
}

export const searchCompanies=async(query:string)=>{
    try{
        const data =await axios.get<SearchResponse>(
           `https://financialmodelingprep.com/api/v3/search-name?query=${query}&apikey=${process.env.REACT_APP_API_KEY}` //key za api klic
        );
        return data;
    } catch(error){
        if(axios.isAxiosError(error)){
            console.log("error message: ", error.message);
            return error.message;
        } else{
            console.log("unexpected error: ", error);
            return "An Un-expected error has occured";
        }
    }
}
import React from 'react'
import "./Card.css"

interface Props {
  companyName: string;
  ticker:string;
  price: number
}

const Card:React.FC<Props> = ({
  companyName, 
  ticker,
  price}: 
  Props):JSX.Element => {
  return (
    <div className='card'>
        <img src="https://1.bp.blogspot.com/-VAQiiVd55-k/VxaGE7PcqvI/AAAAAAAAdlw/tDlZE38Gzjw9C681DO2Jegx7hpo4f96yACLcB/s640/Kamni%25C5%25A1ki%2Bdedec-GPS-1.jpg" 
            alt="Image" 
        />
        <div className='details'>
            <h2>
              {companyName} ({ticker})
            </h2>
            <p>${price}</p>
        </div>
        <p className='info'> loerm10 </p>
    </div>

  )
}

export default Card

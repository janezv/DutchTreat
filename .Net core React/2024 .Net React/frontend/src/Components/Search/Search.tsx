import React, { ChangeEvent, useState, SyntheticEvent } from 'react'

type Props = {}

const Search: React.FC<Props> = (props: Props):JSX.Element => {
    const [search, setSearch]=useState<string>("");

    const handleChage=(e: ChangeEvent<HTMLInputElement>)=>{
        setSearch(e.target.value)
        console.log(e)
    }

    const onClick=(e: SyntheticEvent)=>{

    };

  return (
    <div>
        <input value={search} onChange={(e)=>handleChage(e)}></input>
        <button onClick={(e)=>onClick(e)} />
    </div>
  )
}

export default Search
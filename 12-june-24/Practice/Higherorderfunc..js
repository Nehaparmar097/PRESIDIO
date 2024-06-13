// // let evennumber=(nums)=>{
// //    return nums%2==0;
// // }

// // let higherorderfuntion=(arr,eve)=>{
// //     let n=[];
// //     for(let val in arr)
// //         {
// //             if(eve(val))
// //                 {
// //                     n.push(arr[val]);
// //                 }
// //         }
// //      return n;
// // }
// // let arr=[12,2,3,4,5,6,78,66];console.log(higherorderfuntion(arr,evennumber))
// // let a=higherorderfuntion(arr,evennumber)
// // a
// const accessingParaElement=()=>{
//     let para=document.getElementById('para1')
//     console.log(para)
// }



// const dateDisplay=()=>{
//     document.getElementById('demo').innerHTML=Date()
// }
 //changing the style of an element
 const changeStyle=()=>{
    document.getElementById('demo').style.color='pink'
}


//creating and adding element
// let element=document.createElement('div')
// element.innerHTML='<h4>hey we are still learning</h4>'
// document.body.appendChild(element)



let existingDiv=document.getElementById('divId')
let element=document.createElement('div')
element.innerHTML='<h4>hey we are still learning</h4>'
existingDiv.appendChild(element)


//removing the element

const removeElement=()=>{
    let existingDivWithId=document.getElementById('divId')
    document.body.removeChild(existingDivWithId)
}

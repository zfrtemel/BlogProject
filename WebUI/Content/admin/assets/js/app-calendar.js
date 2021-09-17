$((function(){var e=moment().format("YYYY"),t=moment().format("MM"),i={id:1,events:[{id:"1",start:e+"-"+t+"-08T08:30:00",end:e+"-"+t+"-08T13:00:00",title:"BootstrapDash Meetup",backgroundColor:"#bff2f2",borderColor:"#00cccc",textColor:"#00cccc",description:"In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis az pede mollis..."},{id:"2",start:e+"-"+t+"-10T09:00:00",end:e+"-"+t+"-10T17:00:00",title:"Design Review",backgroundColor:"#e0e4f4",borderColor:"#0a2ba5",textColor:"#0a2ba5",description:"In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis az pede mollis..."},{id:"3",start:e+"-"+t+"-13T12:00:00",end:e+"-"+t+"-13T18:00:00",title:"Lifestyle Conference",backgroundColor:"#ffd5cc",borderColor:"#ff5733",textColor:"#ff5733",description:"Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi..."},{id:"4",start:e+"-"+t+"-15T07:30:00",end:e+"-"+t+"-15T15:30:00",title:"Team Weekly Brownbag",backgroundColor:"#d2e0ff",borderColor:"#0373f3",textColor:"#0373f3",description:"In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis az pede mollis..."},{id:"5",start:e+"-"+t+"-17T10:00:00",end:e+"-"+t+"-19T15:00:00",title:"Music Festival",backgroundColor:"#bfdeff",borderColor:"#007bff",textColor:"#007bff",description:"In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis az pede mollis..."},{id:"6",start:e+"-"+t+"-08T13:00:00",end:e+"-"+t+"-08T18:30:00",title:"Attend Lea's Wedding",backgroundColor:"#d5c2f3",borderColor:"#560bd0",textColor:"#560bd0",description:"In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis az pede mollis..."}]},n={id:2,backgroundColor:"#cbfbb0",borderColor:"#3bb001",textColor:"#3bb001",events:[{id:"7",start:e+"-"+t+"-01T18:00:00",end:e+"-"+t+"-01T23:30:00",title:"Socrates Birthday",backgroundColor:"#d8fed1",borderColor:"#23bf08",description:"In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis az pede mollis..."},{id:"8",start:e+"-"+t+"-21T15:00:00",end:e+"-"+t+"-21T21:00:00",title:"Reynante's Birthday",description:"In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis az pede mollis..."},{id:"9",start:e+"-"+t+"-23T15:00:00",end:e+"-"+t+"-23T21:00:00",title:"Pauline's Birthday",description:"In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis az pede mollis..."}]},o={id:3,backgroundColor:"#fbbfdc",borderColor:"#f10075",textColor:"#f10075",events:[{id:"10",start:e+"-"+t+"-04",end:e+"-"+t+"-06",title:"Feast Day"},{id:"11",start:e+"-"+t+"-26",end:e+"-"+t+"-27",title:"Memorial Day"},{id:"12",start:e+"-"+t+"-28",end:e+"-"+t+"-29",title:"Veteran's Day"}]},a={id:4,backgroundColor:"#ffecca",borderColor:"#ffb52b",textColor:"#ffb52b",events:[{id:"13",start:e+"-"+t+"-06",end:e+"-"+t+"-08",title:"My Rest Day"},{id:"13",start:e+"-"+t+"-29",end:e+"-"+t+"-31",title:"My Rest Day"}]};new Date,function(e){for(var t=0,i=[" AM"," PM"],n=[],o=[12,1,2,3,4,5,6,7,8,9,10,11],a=0;a<o.length;a++){for(n.push(o[a]+":"+t+t+i[0]);t<30;)n.push(o[a]+":"+((t+=30)<10?"O"+t:t)+i[0]);t=0}n=n.concat(n.slice(0).map((function(e){return e.replace(i[0],i[1])}))),$.each(n,(function(t,i){$(e).append('<option value="'+i+'">'+i+"</option>")}))}(".main-event-time"),$("#calendar").fullCalendar({header:{left:"prev,next today",center:"title",right:"month,agendaWeek,agendaDay"},contentHeight:480,firstDay:1,defaultView:"month",allDayText:"All Day",views:{agenda:{columnHeaderHtml:function(e){return"<span>"+e.format("ddd")+"</span><span>"+e.format("DD")+"</span>"}},day:{columnHeader:!1},listMonth:{listDayFormat:"ddd DD",listDayAltFormat:!1},listWeek:{listDayFormat:"ddd DD",listDayAltFormat:!1},agendaThreeDay:{type:"agenda",duration:{days:3},titleFormat:"MMMM YYYY"}},eventSources:[i,n,o,a],eventAfterAllRender:function(e){"listMonth"!==e.name&&"listWeek"!==e.name||e.el.find(".fc-list-heading-main").each((function(){var e=$(this).text().split(" "),t=moment().format("DD");$(this).html(e[0]+"<span>"+e[1]+"</span>"),t===e[1]&&$(this).addClass("now")}))},eventRender:function(e,t){e.description&&(t.find(".fc-list-item-title").append('<span class="fc-desc">'+e.description+"</span>"),t.find(".fc-content").append('<span class="fc-desc">'+e.description+"</span>"));var i=e.source.borderColor?e.source.borderColor:e.borderColor;t.find(".fc-list-item-time").css({color:i,borderColor:i}),t.find(".fc-list-item-title").css({borderColor:i}),t.css("borderLeftColor",i)}});var r=$("#calendar").fullCalendar("getCalendar");window.matchMedia("(min-width: 576px)").matches&&r.changeView("month"),window.matchMedia("(min-width: 992px)").matches&&r.changeView("month"),r.option("windowResize",(function(e){"listWeek"===e.name&&(window.matchMedia("(min-width: 992px)").matches?r.changeView("month"):r.changeView("listWeek"))})),r.getDate(),r.option("select",(function(e,t){$("#modalSetSchedule").modal("show"),$("#mainEventStartDate").val(e.format("LL")),$("#EventEndDate").val(t.format("LL")),$("#mainEventStartTime").val(e.format("LT")).trigger("change"),$("#EventEndTime").val(t.format("LT")).trigger("change")})),r.on("eventClick",(function(e,t,i){var n=$("#modalCalendarEvent");n.modal("show"),n.find(".event-title").text(e.title),e.description?(n.find(".event-desc").text(e.description),n.find(".event-desc").prev().removeClass("d-none")):(n.find(".event-desc").text(""),n.find(".event-desc").prev().addClass("d-none")),n.find(".event-start-date").text(moment(e.start).format("LLL")),n.find(".event-end-date").text(moment(e.end).format("LLL")),n.find(".modal-header").css("backgroundColor",e.source.borderColor?e.source.borderColor:e.borderColor)})),$(".main-nav-calendar-event a").on("click",(function(e){e.preventDefault(),$(this).hasClass("exclude")?($(this).removeClass("exclude"),$(this).is(":first-child")&&r.addEventSource(i),$(this).is(":nth-child(2)")&&r.addEventSource(n),$(this).is(":nth-child(3)")&&r.addEventSource(o),$(this).is(":nth-child(4)")&&r.addEventSource(a)):($(this).addClass("exclude"),$(this).is(":first-child")&&r.removeEventSource(1),$(this).is(":nth-child(2)")&&r.removeEventSource(2),$(this).is(":nth-child(3)")&&r.removeEventSource(3),$(this).is(":nth-child(4)")&&r.removeEventSource(4)),r.render(),window.matchMedia("(max-width: 575px)").matches&&$("body").removeClass("main-content-left-show")}))}));
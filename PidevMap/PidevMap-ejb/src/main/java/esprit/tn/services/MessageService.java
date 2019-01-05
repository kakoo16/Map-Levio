package esprit.tn.services;

import java.util.List;

import javax.ejb.LocalBean;
import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;

import esprit.tn.entities.Message;

@Stateless
@LocalBean

public class MessageService implements MessageServiceRemote {

	@PersistenceContext
	EntityManager em;
	@Override
	public void ajouterMessage(Message e) {
		em.persist(e);	
	}

	@Override
	public List<Message> findAll() {
		// TODO Auto-generated method stub
		
		return em.createQuery("from Message" ,Message.class).getResultList();
	}
	
	@Override
	public void DeleteMessageById(int MessageId) {
		em.remove(em.find(Message.class,MessageId));
		
	}
	



	

	
}
